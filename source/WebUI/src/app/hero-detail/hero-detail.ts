import { Component, EventEmitter, Input, Output } from '@angular/core';
import { Hero } from '../domain/hero';
import { FormsModule } from '@angular/forms';
import { HeroService } from '../hero-service';

@Component({
  selector: 'app-hero-detail',
  imports: [FormsModule],
  templateUrl: './hero-detail.html',
  styleUrl: './hero-detail.scss',
})
export class HeroDetail {
  constructor(private heroService: HeroService) { }

  @Input() hero?: Hero;
  @Output() heroDeleted = new EventEmitter<string>();

  save(): void {
    if (this.hero) {
      this.heroService.updateHero(this.hero).subscribe({
        next: res => {
          if (res.updated) {
            console.log(`Hero with id=${this.hero?.id} updated successfully.`);
          } else {
            console.log(`Hero with id=${this.hero?.id} not updated.`);
          }
        },
        error: err => console.error(`Error updating hero with id=${this.hero?.id}:`, err),
        complete: () => console.debug("Update hero request completed.") // If we were using a progress indicator, we could mark it as complete here.
      });
    }
  }

  delete(): void {
    if (this.hero) {
      this.heroService.deleteHero(this.hero.id).subscribe({
        next: () => {
          console.log(`Hero with id=${this.hero!.id} deleted successfully.`);
          this.heroDeleted.emit(this.hero!.id); // Emit the id of the deleted hero to notify the parent component
        },
        error: err => console.error(`Error deleting hero with id=${this.hero?.id}:`, err),
        complete: () => console.debug("Delete hero request completed.")
      });
    }
  }
}
