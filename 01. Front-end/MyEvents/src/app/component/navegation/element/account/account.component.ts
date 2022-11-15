import { Component, OnInit } from '@angular/core';
import { EApplication } from 'src/app/common/enum/application/application-enums';

@Component({
  selector: 'app-account',
  templateUrl: './account.component.html',
  styleUrls: ['./account.component.css']
})
export class AccountComponent implements OnInit {
  
  public screenProfile: string = EApplication.Profile;
  public screenLogOff: string = EApplication.LogOff;

  constructor() { }

  ngOnInit() {
  }

}
