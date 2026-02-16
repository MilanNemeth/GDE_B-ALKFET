import { Component, signal } from '@angular/core';
import {RouterLink, RouterOutlet} from '@angular/router';
import { HeroesComponent } from './heroes/heroes';
import { Messages } from './messages/messages';

@Component({
  selector: 'app-root',
  imports: [RouterOutlet, RouterLink, HeroesComponent, Messages],
  templateUrl: './app.html',
  styleUrl: './app.scss'
})
export class App {
  title = 'Tour of Heroes';
}