import { Component, Input } from '@angular/core';
import { Hero } from '../domain/hero';
import { UpperCasePipe } from '@angular/common';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-hero-detail',
  imports: [UpperCasePipe, FormsModule],
  templateUrl: './hero-detail.html',
  styleUrl: './hero-detail.scss',
})
export class HeroDetail {
  @Input() hero?: Hero;
}
