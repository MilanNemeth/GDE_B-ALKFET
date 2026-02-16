import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HEROES } from '../domain/mock-heroes';
import { MessageService } from '../message-service';

@Component({
  selector: 'app-hero-creator',
  imports: [FormsModule],
  templateUrl: './hero-creator.html',
  styleUrl: './hero-creator.scss',
})
export class HeroCreator {
  constructor(private messageService: MessageService) { }
  name = '';
  private heros = HEROES;

  create(): void {
    const newHero = { id: this.heros.length + 1, name: this.name };
    this.heros.push(newHero);
    this.name = '';
    let msg = `Hero created with name: ${newHero.name}`;
    console.log(msg);
    this.messageService.add(msg);
  }
}
