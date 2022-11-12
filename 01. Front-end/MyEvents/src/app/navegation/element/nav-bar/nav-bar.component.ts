import { Component, OnInit } from '@angular/core';
import { EApplication } from 'src/app/common/enum/application/application-enums';

@Component({
  selector: 'app-nav-bar',
  templateUrl: './nav-bar.component.html',
  styleUrls: ['./nav-bar.component.css']
})
export class NavBarComponent implements OnInit {

  public screenEvents: string;
  public screenSpeakers: string;
  public isCollapsed = true;

  constructor() {
    this.screenEvents = EApplication.Events;
    this.screenSpeakers = EApplication.Speakers;
   }

  ngOnInit(): void {
  }
}
