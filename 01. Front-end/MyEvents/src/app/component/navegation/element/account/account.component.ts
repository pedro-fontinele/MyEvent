import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { EApplication } from 'src/app/common/enum/application/application-enums';

@Component({
  selector: 'app-account',
  templateUrl: './account.component.html',
  styleUrls: ['./account.component.css']
})
export class AccountComponent implements OnInit {
  
  public screenProfile: string = EApplication.Profile;
  public screenLogOff: string = EApplication.LogOff;

  constructor(public router: Router) { }

  ngOnInit() {
  }

  routerProfile(): void {
    this.router.navigate(['/user/profile']);
  }

  routerGetOut(): void {
    this.router.navigate(['/user/login']);
  }

}
