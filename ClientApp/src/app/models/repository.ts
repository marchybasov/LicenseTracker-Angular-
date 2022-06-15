import { Users } from './User.model';
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Filter } from './configClasses.repository';
import { UserPCs } from './UserPC.model';

const usersUrl = '/api/users/';
const userPCsUrl = '/api/pcs';

@Injectable()
export class Repository {
  user: Users;
  users: Users[];
  userPCs: UserPCs[];
  filter: Filter = new Filter();
  constructor(private http: HttpClient) {
    // this.filter.category = 'soccer';
    this.filter.related = true;
    this.getUsers();
    this.getUserPCs();
  }

  getUser(id: number) {
    this.http.get<Users>(`${usersUrl}/${id}`).subscribe((p) => {
      this.user = p;
      console.log('Product Data Received');
    });
  }
  getUsers() {
    let url = `${usersUrl}?related=${this.filter.related}`;
    if (this.filter.category) {
      url += `&category=${this.filter.category}`;
    }
    if (this.filter.search) {
      url += `&search=${this.filter.search}`;
    }
    this.http.get<Users[]>(url).subscribe((users) => (this.users = users));
  }

  getUserPCs() {
    debugger;
    this.http
      .get<UserPCs[]>(userPCsUrl)
      .subscribe((pcs) => (this.userPCs = pcs));
  }
}
