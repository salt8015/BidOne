import { TestBed } from '@angular/core/testing';
import { HomeServiceMock } from './services/home.service.mock';
import { HomeService } from './services/home.service';
import { HomeComponent } from './home.component';

describe('HomeComponent', () => {
  let component: HomeComponent;
  let homeServiceMock: HomeServiceMock;

  beforeEach(async () => {
    homeServiceMock = new HomeServiceMock()
    await TestBed.configureTestingModule({
      providers: [
        HomeComponent,
        { provide: HomeService, useValue: homeServiceMock.mock.Object }
      ]
    })
      .compileComponents();
  });
  beforeEach(() => {
    component = TestBed.inject(HomeComponent);
  });

  it('01-home on init', () => {
    component.ngOnInit();

    expect(component.user.firstName).toBe('');
    expect(component.user.lastName).toBe('');
  });
});
