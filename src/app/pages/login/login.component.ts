import { Component, OnChanges, OnDestroy, OnInit, SimpleChanges } from '@angular/core';
import { Router } from '@angular/router';
import { User } from 'src/app/interfaces/User';
import { AuthService } from 'src/app/services/auth.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss']
})
export class LoginComponent implements OnInit, OnChanges, OnDestroy {
  public text: string='';
  public isDisabled: boolean=false;
  public user: User={
    username:'',
    password:''

  }
  public error:boolean | string=false;

  constructor(private authService: AuthService, private router: Router) { }

  ngOnInit(): void {

    this.text='TEST';


  }
  doLogin():void {
    this.error=false;
    console.log('Login Clicked', this.user);

    if(this.validateEmail(this.user.username))
    {
      this.authService.login(this.user).subscribe((response: any) =>{
        console.log(response);
        if(response && response.token)
        {
          localStorage.setItem('token', response.token);
          this.router.navigate(['/dashboard']);
        }
      })
    }
    else{
      this.error="Email is not valid";

    }

  }

  validateEmail(email:string) {
    const re = /^(([^<>()[\]\\.,;:\s@"]+(\.[^<>()[\]\\.,;:\s@"]+)*)|(".+"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/;
    return re.test(String(email).toLowerCase());
  }








  ngOnDestroy() {}
  ngOnChanges (){ }
}
