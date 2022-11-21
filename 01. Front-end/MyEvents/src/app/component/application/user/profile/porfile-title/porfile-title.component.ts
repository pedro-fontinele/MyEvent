import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { EApplication } from 'src/app/common/enum/application/application-enums';
import { EButton } from 'src/app/common/enum/button/button';

@Component({
  selector: 'app-porfile-title',
  templateUrl: './porfile-title.component.html',
  styleUrls: ['./porfile-title.component.css']
})
export class PorfileTitleComponent implements OnInit {

  constructor(public router: Router){
  }

  ngOnInit(){
  }

  public porfileTitle: string = EApplication.Profile;
  public dashboardButton: string = EButton.Dashboard;

  routerList(): void{
    this.router.navigate(['/dashboard']);
  }

}
