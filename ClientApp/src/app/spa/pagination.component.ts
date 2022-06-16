import { Component } from '@angular/core';
import { NavigationService } from '../models/navigation.service';

@Component({
  selector: 'spa-pagination',
  templateUrl: 'pagination.component.html',
})
export class PaginationComponent {
  constructor(public navigation: NavigationService) {}

  get pages(): number[] {
    if (this.navigation.usersCount > 0) {
      return Array(
        Math.ceil(this.navigation.usersCount / this.navigation.usersPerPage)
      )
        .fill(0)
        .map((x, i) => i + 1);
    } else {
      return [];
    }
  }
}
