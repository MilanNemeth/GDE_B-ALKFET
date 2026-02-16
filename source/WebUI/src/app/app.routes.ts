import { Routes } from '@angular/router';
import { HeroesComponent } from './heroes/heroes';
import { HeroCreator } from './hero-creator/hero-creator';

export const routes: Routes = [
    {
    path: '',
    component: HeroesComponent,
    title: 'Hero List',
  },
  {
    path: 'create',
    component: HeroCreator,
    title: 'Create Hero',
  },
];
