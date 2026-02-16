import { Component, signal } from '@angular/core';
import { RouterLink, RouterOutlet, RouterLinkActive } from '@angular/router';
import { Messages } from './messages/messages';

@Component({
  selector: 'app-root',
  imports: [RouterOutlet, RouterLink, RouterLinkActive, Messages],
  templateUrl: './app.html',
  styleUrl: './app.scss'
})
export class App {
  title = 'Tour of Heroes';
}