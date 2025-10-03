import { ComponentFixture, TestBed } from '@angular/core/testing';
import { SweDemoUi } from './swe-demo-ui';

describe('SweDemoUi', () => {
  let component: SweDemoUi;
  let fixture: ComponentFixture<SweDemoUi>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [SweDemoUi],
    }).compileComponents();

    fixture = TestBed.createComponent(SweDemoUi);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
