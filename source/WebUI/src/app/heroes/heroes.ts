import { Component } from '@angular/core';
import { Hero } from '../domain/hero';
import { FormsModule } from '@angular/forms';
import { HeroDetail } from '../hero-detail/hero-detail';
import { HeroService } from '../hero-service';
import { MessageService } from '../message-service';

@Component({
  standalone: true,
  selector: 'app-heroes',
  templateUrl: './heroes.html',
  styleUrls: ['./heroes.scss'],
  imports: [FormsModule, HeroDetail]
})
export class HeroesComponent {
  constructor(private heroService: HeroService, private messageService: MessageService) { }

  ngOnInit(): void {
    this.getHeroes();
  }

  getHeroes(): void {
    this.heroService.getHeroes()
      .subscribe(
        {
          next: heroes => this.heroes = heroes,
          error: error => console.error(error),
          complete: () => console.log('Completed fetching heroes')
        });
  }

  heroes: Hero[] = [];
  selectedHero?: Hero;

  onSelect(hero: Hero): void {
    this.selectedHero = hero;
    this.messageService.add(`HeroesComponent: Selected hero id=${hero.id}`);
  }

}
