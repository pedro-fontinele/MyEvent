import { Component, OnInit } from '@angular/core';
import { EApplication } from 'src/app/common/enum/application-enums';

@Component({
  selector: 'app-nav-bar',
  templateUrl: './nav-bar.component.html',
  styleUrls: ['./nav-bar.component.css']
})
export class NavBarComponent implements OnInit {

  public telaEventos: string = '';
  public telaPalestrantes: string = '';
  public isCollapsed = true;

  constructor() {
    this.telaEventos = EApplication.Eventos;
    this.telaPalestrantes = EApplication.Palestrantes;
   }

  ngOnInit(): void {
  }
}
