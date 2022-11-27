import { EButton } from 'src/app/common/enum/button/button';
import { Component, OnInit } from '@angular/core';
import { EApplication } from 'src/app/common/enum/application/application-enums';
import { Router } from '@angular/router';

@Component({
  selector: 'app-events-title',
  templateUrl: './events-title.component.html',
  styleUrls: ['./events-title.component.css']
})
export class ApplicationEventsTitleComponent implements OnInit {

  constructor(public router: Router){
  }

  ngOnInit(){
  }

  public eventsTitle: string = EApplication.Events;
  public dashboardButton: string = EButton.Dashboard;
  public viewList: string = EButton.List;

  routerList(): void{
    this.router.navigate(['/dashboard']);
  }

}
