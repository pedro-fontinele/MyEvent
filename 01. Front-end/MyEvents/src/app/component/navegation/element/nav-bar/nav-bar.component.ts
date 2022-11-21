import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { EApplication } from 'src/app/common/enum/application/application-enums';

@Component({
  selector: 'app-nav-bar',
  templateUrl: './nav-bar.component.html',
  styleUrls: ['./nav-bar.component.css']
})
export class NavBarComponent implements OnInit {

  public screenEvents: string;
  public screenSpeakers: string;
  public screenContacts: string;
  public isCollapsed = true;

  constructor(public router: Router) {
    this.screenEvents = EApplication.Events;
    this.screenSpeakers = EApplication.Speakers;
    this.screenContacts = EApplication.Contacts;
   }

  ngOnInit(): void {
  }

  routerEvents(): void {
    this.router.navigate(['/events/list']);
  }

  shouldShowNavbar(): boolean{
    return this.router.url !== '/user/login';
  }

  routerSpeakers(): void {
    this.router.navigate(['/speakers']);
  }

  routerContacts(): void {
    this.router.navigate(['/contacts']);
  }
}
