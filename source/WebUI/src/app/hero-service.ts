import { Injectable } from '@angular/core';
import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { Hero } from './domain/hero';
import { Observable, throwError } from 'rxjs';
import { catchError, map, tap } from 'rxjs/operators';
import { MessageService } from './message-service';
import { environment } from './../environments/environment';
import { UpdateResponse } from './domain/updateResponse';

@Injectable({
  providedIn: 'root',
})
export class HeroService {
  constructor(
    private http: HttpClient,
    private messageService: MessageService
  ) { }

  apiUrl = environment.apiUrl;

  getHero(id: number): Observable<Hero> {
    const url = `${this.apiUrl}/hero/${id}`;
    return this.http.get<Hero>(url).pipe(
      tap(hero => this.messageService.add(`HeroService: fetched hero with id=${hero.id}`)),
      catchError(this.handleError)
    );
  }

  getHeroes(): Observable<Hero[]> {
    const url = `${this.apiUrl}/hero`;
    return this.http.get<Hero[]>(url).pipe(
      tap(heroes => this.messageService.add(`HeroService: fetched ${heroes.length} heroes`)),
      catchError(this.handleError)
    );
  }

  createHero(hero: Hero): Observable<Hero> {
    const url = `${this.apiUrl}/hero`;
    return this.http.post<Hero>(url, hero).pipe(
      tap(heroe => this.messageService.add(`HeroService: created hero with name=${heroe.name}`)),
      catchError(this.handleError)
    );
  }

  updateHero(hero: Hero): Observable<UpdateResponse> {
    const url = `${this.apiUrl}/hero/${hero.id}`;
    return this.http.put<UpdateResponse>(url, hero).pipe(
      tap(res => {
        if (res.updated) {
          this.messageService.add(`HeroService: updated hero with id=${hero.id}`);
        } else {
          this.messageService.add(`HeroService: hero with id=${hero.id} not updated`);
        }
        return res;
      }),
      catchError(this.handleError)
    );
  }

  deleteHero(id: number): Observable<void> {
    const url = `${this.apiUrl}/hero/${id}`;
    return this.http.delete<{ id: number; deleted: boolean }>(url).pipe(
      map(res => {
        if (res.deleted) {
          this.messageService.add(`HeroService: deleted hero with id=${id}`);
        } else {
          this.messageService.add(`HeroService: hero with id=${id} not found`);
        }
        return;
      })
    );
  }

  private handleError(err: HttpErrorResponse): Observable<never> {
    // Production apps should also send the error to some remote logging infrastructure
    let errorMessage = '';
    if (err.error instanceof ErrorEvent) {
      // Client side or network related error
      errorMessage = `An error occurred: ${err.error.message}`;
    } else {
      // Backend responed with an unsuccessful response code.
      errorMessage = `Server returned code: ${err.status}, error message is: ${err.message}`;
    }
    console.error(errorMessage);
    return throwError(() => errorMessage);
  }

}
