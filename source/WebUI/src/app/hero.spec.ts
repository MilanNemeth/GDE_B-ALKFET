import { TestBed } from '@angular/core/testing';

import { Hero } from './hero';

describe('Hero', () => {
  let service: Hero;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(Hero);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
