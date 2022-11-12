import { EButton } from '../../common/enum/button/button';
import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { EventsColumnsTable } from 'src/app/common/class-support/events-columns-table/events-columns-table';
import { EApplication } from 'src/app/common/enum/application/application-enums';
import { EMessage } from 'src/app/common/enum/message/message-enums';

@Component({
  selector: 'app-events',
  templateUrl: './events.component.html',
  styleUrls: ['./events.component.css']
})
export class EventsComponent implements OnInit {

  // propriedade da entidade
  public events: any = [];

  // propriedades dos enumedores
  public eventsTitle: string = EApplication.Events;
  public searchButton: string = EButton.Search;
  public editButton: string = EButton.Edit;
  public deleteButton: string = EButton.Delete;
  public NoDataFound: string = EMessage.NoDataFound;

  // assets de imagem
  public sourceImages: string = '/assets/image/';
  public showImages: boolean = true;

  // campo de pesquisa event
  private _filterList: string = '';
  public filteredEvents: any = [];

  public get filterList (){
    return this._filterList;
  }

  public set filterList (value: string){
    this._filterList = value;
    this.events = this._filterList ? this.filterEvents(this._filterList) : this.getEvents();
  }

  // classe de apoio
  public eventsColumnsTable: EventsColumnsTable;

  constructor (private http: HttpClient) { 
    // instancia a classe de apoio para descrição das colunas
    this.eventsColumnsTable =  new EventsColumnsTable();
  }

  public getEvents (): void{
    this.http.get('https://localhost:5001/api/v1/Evento').subscribe(
      response => this.events = response
    );
  }
  
  showOrHideImagens(){
    this.showImages = !this.showImages;
  }

  filterEvents(filterFor: string){
    filterFor = filterFor.toLocaleUpperCase();
    return this.events.filter((event: any) => event.theme.toLocaleUpperCase().indexOf(filterFor) !== -1)
  }

  ngOnInit (): void {
    this.getEvents();
  }
}
