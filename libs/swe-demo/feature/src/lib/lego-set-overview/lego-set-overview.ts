import { Component, inject } from "@angular/core";
import { LegoSetService } from "@swe-demo/swe-demo-domain";

@Component({
  selector: "lib-swe-demo-feature-lego-set-overview",
  imports: [],
  templateUrl: "./lego-set-overview.html",
  styleUrl: "./lego-set-overview.css",
})
export class LegoSetOverview {
  private readonly legoSetService = inject(LegoSetService);

  legoSets = this.legoSetService.legoSetRecource.value;
}
