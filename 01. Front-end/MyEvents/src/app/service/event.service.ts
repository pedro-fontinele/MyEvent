import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Event } from '../common/model/event';

@Injectable({
  providedIn: 'root'
})
export class EventService {

   private readonly baseUrl: string = 'https://localhost:5001/api/v1/event';

   constructor (private http: HttpClient) { }

   public getAllEvents(): Observable<Event[]> {
     return this.http.get<Event[]>(this.baseUrl);
   }

   public getEventsById(idEvent: number): Observable<Event[]> {
     return this.http.get<Event[]>(`${this.baseUrl}/id/${idEvent}`);
   }

   public getEventsByTheme(theme: string): Observable<Event[]> {
     return this.http.get<Event[]>(`${this.baseUrl}/theme/${theme}`);
   }
}
