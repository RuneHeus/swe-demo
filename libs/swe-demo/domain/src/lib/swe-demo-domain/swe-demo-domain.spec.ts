import { ComponentFixture, TestBed } from '@angular/core/testing';
import { SweDemoDomain } from './swe-demo-domain';

describe('SweDemoDomain', () => {
  let component: SweDemoDomain;
  let fixture: ComponentFixture<SweDemoDomain>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [SweDemoDomain],
    }).compileComponents();

    fixture = TestBed.createComponent(SweDemoDomain);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
