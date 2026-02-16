import { ComponentFixture, TestBed } from '@angular/core/testing';

import { HeroCreator } from './hero-creator';

describe('HeroCreator', () => {
  let component: HeroCreator;
  let fixture: ComponentFixture<HeroCreator>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [HeroCreator]
    })
    .compileComponents();

    fixture = TestBed.createComponent(HeroCreator);
    component = fixture.componentInstance;
    await fixture.whenStable();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
