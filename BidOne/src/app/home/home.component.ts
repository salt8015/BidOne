import { Inject, Component, OnInit } from '@angular/core';
import { HomeService } from './services/home.service'
import { User } from './models/homeModels';

@Component({
  selector: 'app-home-page',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})

export class HomeComponent implements OnInit {
  public user: User;
  constructor(
    @Inject(HomeService) private homeService: HomeService
  ) { }

  ngOnInit(): void {
    this.user = {
      firstName: '',
      lastName: ''
    };
  }

  async save(): Promise<void> {

    await this.homeService.saveUser(this.user);
  }
}

