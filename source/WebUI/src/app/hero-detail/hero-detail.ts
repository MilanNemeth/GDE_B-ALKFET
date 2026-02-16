import { Component, Input } from '@angular/core';
import { Hero } from '../domain/hero';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-hero-detail',
  imports: [FormsModule],
  templateUrl: './hero-detail.html',
  styleUrl: './hero-detail.scss',
})
export class HeroDetail {
  @Input() hero?: Hero;

  save(): void {
    if (this.hero) {
      console.log(`Saved hero: ${this.hero.name}`);
    }
  }
}
