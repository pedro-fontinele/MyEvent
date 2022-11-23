import { EButton } from 'src/app/common/enum/button/button';
import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-registration',
  templateUrl: './registration.component.html',
  styleUrls: ['./registration.component.css']
})
export class RegistrationComponent implements OnInit {

  constructor(public router: Router) { }

  ngOnInit() { }

  public alreadyRegisteredButton = EButton.AlreadyRegistered;
  public doneButton = EButton.Done;

  public routerLogin(): void {
    this.router.navigate(['/user/login']);
  }

}
