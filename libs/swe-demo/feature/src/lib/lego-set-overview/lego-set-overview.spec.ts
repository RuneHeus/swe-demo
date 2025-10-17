import { ComponentFixture, TestBed } from '@angular/core/testing';
import { LegoSetOverview } from './lego-set-overview';

describe('LegoSetOverview', () => {
  let component: LegoSetOverview;
  let fixture: ComponentFixture<LegoSetOverview>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [LegoSetOverview],
    }).compileComponents();

    fixture = TestBed.createComponent(LegoSetOverview);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
