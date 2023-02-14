import { Batch } from './../../common/model/batch';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable, take } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class BatchService {

  private readonly baseUrl: string = 'https://localhost:5001/api/v1/batch';

  constructor (private http: HttpClient) { 
  }

  public getAllBatch(idEvent: number): Observable<Batch[]> {
    return this.http.get<Batch[]>(`${this.baseUrl}/id/${idEvent}`).pipe(take(1));
  }

  public GetBatchById(idBatch: number): Observable<Batch> {
    return this.http.get<Batch>(`${this.baseUrl}/id/${idBatch}`).pipe(take(1));
  }

  public postBatchs(batch: Batch): Observable<Batch> {
   return this.http.post<Batch>(this.baseUrl, batch).pipe(take(1));
  }

  public putBatchs(idBatch: number, batch: Batch): Observable<Batch> {
   return this.http.put<Batch>(`${this.baseUrl}/id/${idBatch}`, batch).pipe(take(1));
  }

  public deleteBatchById(idBatch: number): Observable<Batch> {
   return this.http.delete<Batch>(`${this.baseUrl}/id/${idBatch}`).pipe(take(1));
  }

  public deleteAllBatchs(): Observable<Batch> {
    return this.http.delete<Batch>(this.baseUrl).pipe(take(1));
  }

}
