import { Users } from './User.model';
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Filter, Pagination } from './configClasses.repository';
import { UserPCs } from './UserPC.model';
import { Statistic } from './UsageStatistic.model';

const usersUrl = '/api/users/';
const userPCsUrl = '/api/pcs';
const statisticUrl = 'api/statistic';

@Injectable()
export class Repository {
  user: Users;
  users: Users[];
  userPCs: UserPCs[];
  filter: Filter = new Filter();
  categories: string[] = [];
  paginationObject = new Pagination();
  statistic: Statistic;

  constructor(private http: HttpClient) {
    this.filter.related = true;
    //this.getStatistic();
    //this.getUsers();

    this.getUserPCs();
  }

  getUser(id: number) {
    this.http.get<Users>(`${usersUrl}/${id}`).subscribe((p) => {
      this.user = p;
      console.log('Product Data Received');
    });
  }

  getStatistic() {
    let url = `${statisticUrl}`;
    if (this.filter.category) {
      url += `/${this.filter.category}`;
    }
    this.http
      .get<Statistic>(url)
      .subscribe((statics) => (this.statistic = statics));
  }

  getUsers() {
    let url = `${usersUrl}`;
    if (this.filter.category) {
      url += `${this.filter.category}`;
    }
    if (this.filter.search) {
      url += `&search=${this.filter.search}`;
    }
    this.http.get<Users[]>(url).subscribe((users) => (this.users = users));
  }

  getUserPCs() {
    let url = `${userPCsUrl}`;
    if (this.filter.category) {
      url += `/${this.filter.category}`;
    }
    this.http.get<UserPCs[]>(url).subscribe((pcs) => (this.userPCs = pcs));
  }
}
