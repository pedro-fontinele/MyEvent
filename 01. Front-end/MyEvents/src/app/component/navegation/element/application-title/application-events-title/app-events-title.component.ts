import { Component, OnInit } from '@angular/core';
import { EApplication } from 'src/app/common/enum/application/application-enums';

@Component({
  selector: 'app-events-title',
  templateUrl: './app-events-title.component.html',
  styleUrls: ['./app-events-title.component.css']
})
export class ApplicationEventsTitleComponent implements OnInit {

  constructor() { }

  public eventsTitle: string = EApplication.Events;

  ngOnInit() {
  }

}
