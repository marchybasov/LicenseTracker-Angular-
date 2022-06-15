import { Component } from '@angular/core';
import { Repository } from './models/repository';
import { Users } from './models/User.model';
import { UserPCs } from './models/UserPC.model';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
})
export class AppComponent {
  constructor(private repo: Repository) {}
  get users(): Users[] {
    return this.repo.users;
  }

  get usersPCs(): UserPCs[] {
    return this.repo.userPCs;
  }
}
