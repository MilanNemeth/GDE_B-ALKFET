import { TestBed } from '@angular/core/testing';
import { HttpClientTestingModule, HttpTestingController } from '@angular/common/http/testing';

import { HeroService } from './hero-service';
import { Hero } from './domain/hero';
import { MessageService } from './message-service';
import { environment } from './../environments/environment';

describe('HeroService', () => {
  let service: HeroService;
  let httpMock: HttpTestingController;
  const apiUrl = environment.apiUrl;

  beforeEach(() => {
    TestBed.configureTestingModule({
      imports: [HttpClientTestingModule],
      providers: [MessageService]
    });
    service = TestBed.inject(HeroService);
    httpMock = TestBed.inject(HttpTestingController);
  });

  afterEach(() => {
    httpMock.verify();
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });

  it('fetches all heroes', () => {
    const mock: Hero[] = [{ id: 1, name: 'Test' }];
    service.getHeroes().subscribe(heroes => {
      expect(heroes).toEqual(mock);
    });
    const req = httpMock.expectOne(`${apiUrl}/hero`);
    expect(req.request.method).toBe('GET');
    req.flush(mock);
  });

  it('fetches a hero by id', () => {
    const mock: Hero = { id: 2, name: 'Alice' };
    service.getHero(2).subscribe(h => {
      expect(h).toEqual(mock);
    });
    const req = httpMock.expectOne(`${apiUrl}/hero/2`);
    expect(req.request.method).toBe('GET');
    req.flush(mock);
  });

  it('creates a hero', () => {
    const newHero: Hero = { id: 0, name: 'New' };
    service.createHero(newHero).subscribe(h => {
      expect(h).toEqual(newHero);
    });
    const req = httpMock.expectOne(`${apiUrl}/hero`);
    expect(req.request.method).toBe('POST');
    req.flush(newHero);
  });

  it('updates a hero', () => {
    const hero: Hero = { id: 3, name: 'Upd' };
    service.updateHero(hero).subscribe(res => {
      expect(res).toEqual(hero);
    });
    const req = httpMock.expectOne(`${apiUrl}/hero/3`);
    expect(req.request.method).toBe('PUT');
    req.flush({ id: 3, updated: true });
  });

  it('deletes a hero', () => {
    service.deleteHero(5).subscribe(res => {
      expect(res).toBeUndefined();
    });
    const req = httpMock.expectOne(`${apiUrl}/hero/5`);
    expect(req.request.method).toBe('DELETE');
    req.flush({ id: 5, deleted: true });
  });
});
