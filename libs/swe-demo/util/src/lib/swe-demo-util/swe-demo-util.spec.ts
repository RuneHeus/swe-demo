import { ComponentFixture, TestBed } from '@angular/core/testing';
import { SweDemoUtil } from './swe-demo-util';

describe('SweDemoUtil', () => {
  let component: SweDemoUtil;
  let fixture: ComponentFixture<SweDemoUtil>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [SweDemoUtil],
    }).compileComponents();

    fixture = TestBed.createComponent(SweDemoUtil);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
