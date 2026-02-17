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
export class HeroesComponent implements OnInit{
  constructor(private heroService: HeroService, private messageService: MessageService) { }

  heroes = signal<Hero[]>([]);
  selectedHero?: Hero;

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

  onSelect(hero: Hero): void {
    this.selectedHero = hero;
    this.messageService.add(`HeroesComponent: Selected hero id=${hero.id}`);
  }

  handleDelete(deletedHeroId: number): void {
    this.heroes.update(heroes => heroes.filter(hero => hero.id !== deletedHeroId));
    if (this.selectedHero?.id === deletedHeroId) {
      this.selectedHero = undefined; // Clear the selected hero if it was deleted
    }
  }
}
