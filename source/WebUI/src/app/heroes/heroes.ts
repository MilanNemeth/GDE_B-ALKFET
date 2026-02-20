import { Component, OnInit, signal } from '@angular/core';
import { Hero } from '../domain/hero';
import { FormsModule } from '@angular/forms';
import { HeroDetail } from '../hero-detail/hero-detail';
import { HeroService } from '../hero-service';
import { MessageService } from '../message-service';
import { CommonModule } from '@angular/common';

@Component({
  standalone: true,
  selector: 'app-heroes',
  templateUrl: './heroes.html',
  styleUrls: ['./heroes.scss'],
  imports: [FormsModule, HeroDetail, CommonModule]
})
export class HeroesComponent implements OnInit {
  constructor(private heroService: HeroService, private messageService: MessageService) { }

  heroes = signal<Hero[]>([]);
  selectedHero = signal<Hero | undefined>(undefined);

  ngOnInit(): void {
    this.getHeroes();
  }

  getHeroes(): void {
    this.heroService.getHeroes()
      .subscribe(
        {
          next: heroes => this.heroes.set(heroes),
          error: error => console.error(error),
          complete: () => console.log('Completed fetching heroes')
        });
  }

  onSelect(hero: Hero | undefined): void {
    if (this.selectedHero() === hero) {
      this.selectedHero.set(undefined); // Clear the selected hero if the same hero is clicked again
      return;
    }
    this.selectedHero.set(hero);
    this.messageService.add(`HeroesComponent: ${hero ? `Selected hero id=${hero.id}` : 'Cleared selected hero'}`);
  }

  handleDelete(deletedHeroId: string): void {
    this.heroes.update(heroes => heroes.filter(hero => hero.id !== deletedHeroId));
    if (this.selectedHero()?.id === deletedHeroId) {
      this.selectedHero.set(undefined); // Clear the selected hero if it was deleted
    }
  }

}
