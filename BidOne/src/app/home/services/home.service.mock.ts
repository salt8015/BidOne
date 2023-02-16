import { Mock } from 'ts-mocks';
import { HomeService } from './home.service';

export class HomeServiceMock {
    mock = new Mock<HomeService>();
    constructor() {
        this.mock.setup(P => P.saveUser).is(Mock.ANY_FUNC);
    }
}