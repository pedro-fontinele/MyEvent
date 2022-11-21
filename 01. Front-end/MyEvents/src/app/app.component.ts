import { Component } from '@angular/core';
import { EMessage } from './common/enum/message/message/message-enums';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  
  public loadingApplication: string = EMessage.Loading;

  constructor() {
  }

  ngOnInit() {
  }
}
