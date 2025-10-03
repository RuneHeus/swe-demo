import { ComponentFixture, TestBed } from '@angular/core/testing';
import { SweDemoFeature } from './swe-demo-feature';

describe('SweDemoFeature', () => {
  let component: SweDemoFeature;
  let fixture: ComponentFixture<SweDemoFeature>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [SweDemoFeature],
    }).compileComponents();

    fixture = TestBed.createComponent(SweDemoFeature);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
