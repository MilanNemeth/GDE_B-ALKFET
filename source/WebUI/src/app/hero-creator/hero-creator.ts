import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { MessageService } from '../message-service';
import { HeroService } from '../hero-service';

@Component({
  selector: 'app-hero-creator',
  imports: [FormsModule],
  templateUrl: './hero-creator.html',
  styleUrl: './hero-creator.scss',
})
export class HeroCreator {
  constructor(private heroService: HeroService, private messageService: MessageService) { }
  name = '';

  create(): void {
    // TODO: solve id generation in a better way
    const newHero = { id: Math.floor(Math.random() * 1000) + 1, name: this.name };
    this.heroService.createHero(newHero).subscribe({
      next: hero => {
        console.log(`Hero created with id=${hero.id} and name=${hero.name}`);
        this.messageService.add(`Hero created with id=${hero.id} and name=${hero.name}`);
      },
      error: err => console.error('Error creating hero:', err),
      complete: () => console.debug('Create hero request completed.')
    });
    this.name = '';
  }
}
