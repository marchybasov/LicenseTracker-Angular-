import { Component } from '@angular/core';
import { Repository } from './models/repository';
import { Users } from './models/User.model';
import { UserPCs } from './models/UserPC.model';
import { NavigationService } from './models/navigation.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
})
export class AppComponent {
  constructor(private repo: Repository, public service: NavigationService) {}
  get users(): Users[] {
    return this.repo.users;
  }

  get usersPCs(): UserPCs[] {
    return this.repo.userPCs;
  }
}
