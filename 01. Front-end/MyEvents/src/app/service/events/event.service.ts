import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable, take } from 'rxjs';
import { Event } from '@app/common/model/event';

@Injectable({
  providedIn: 'root'
})
export class EventService {

   private readonly baseUrl: string = 'https://localhost:5001/api/v1/event';

   constructor (private http: HttpClient) { 
   }

   public getAllEvents(): Observable<Event[]> {
     return this.http.get<Event[]>(this.baseUrl).pipe(take(1));
   }

   public getEventsById(idEvent: number): Observable<Event> {
     return this.http.get<Event>(`${this.baseUrl}/id/${idEvent}`).pipe(take(1));
   }

   public getEventsByTheme(theme: string): Observable<Event[]> {
     return this.http.get<Event[]>(`${this.baseUrl}/theme/${theme}`).pipe(take(1));
   }

   public postEvents(event: Event): Observable<Event> {
    return this.http.post<Event>(this.baseUrl, event).pipe(take(1));
   }

   public putEvents(id: number, event: Event): Observable<Event> {
    return this.http.put<Event>(`${this.baseUrl}/id/${id}`, event).pipe(take(1));
   }

   public deleteEventById(idEvent: number): Observable<Event> {
    return this.http.delete<Event>(`${this.baseUrl}/id/${idEvent}`).pipe(take(1));
   }

   public deleteAllEvents(): Observable<Event> {
     return this.http.delete<Event>(this.baseUrl).pipe(take(1));
   }
   
}
 