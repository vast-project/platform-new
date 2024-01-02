import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'eu-values',
  templateUrl: './eu-values.component.html',
  styleUrls: ['./eu-values.component.css']
})
export class EuValuesComponent implements OnInit {

  values = [
    {
      title: 'Human dignity',
      shortDescription: 'Human dignity is inviolable. It must be respected, protected and constitutes the real basis of fundamental rights.',
      extendedDescription: 'Human dignity, a concept deeply rooted in human history, is the cornerstone of fundamental rights. The idea that every individual, irrespective of their circumstances, possesses an intrinsic worth is central to the principles of justice, fairness, and human rights. It\'s this belief that underpins many international laws and treaties, serving as a guiding principle for societies that strive for fairness, respect, and equality.In the context of the EU, human dignity is treated as a foundational value, ensuring that policies, laws, and actions uphold the sanctity and worth of every individual.'
    },
    {
      title: 'Freedom',
      shortDescription: 'Freedom of movement gives citizens the right to move and reside freely within the Union. Individual freedoms such as respect for private life, freedom of thought, religion, assembly, expression and information are protected by the EU Charter of Fundamental Rights.',
      extendedDescription: 'Freedom, in the context of the EU, extends beyond just the physical movement across borders. It encapsulates the broader liberties that are essential for the holistic development of individuals and communities. The EU Charter of Fundamental Rights ensures that citizens have the right to express their thoughts without fear, practice their religion or belief, assemble for peaceful purposes, and access information. These freedoms form the bedrock of a democratic society, ensuring that individuals can lead fulfilling lives while contributing to the social, economic, and cultural fabric of the Union.'
    },
    {
      title: 'Democracy',
      shortDescription: 'The functioning of the EU is founded on representative democracy. A European citizen automatically enjoys political rights. Every adult EU citizen has the right to stand as a candidate and to vote in elections to the European Parliament. EU citizens have the right to stand as a candidate and to vote in their country of residence, or in their country of origin.',
      extendedDescription: 'Democracy, as envisioned by the EU, is not just about periodic elections. It\'s about ensuring that the voice of every citizen matters.Through representative democracy, citizens of the EU have the power to influence policies and decisions that impact their lives.The European Parliament, elected by the citizens, plays a pivotal role in shaping the future of the Union.Furthermore, the EU emphasizes the importance of active citizenship, encouraging its citizens to be informed, engaged, and participatory.This democratic ethos ensures that the EU remains transparent, accountable, and responsive to the needs of its people.'
    },
    {
      title: 'Equality',
      shortDescription: 'Equality is about equal rights for all citizens before the law. The principle of equality between women and men underpins all European policies and is the basis for European integration. It applies in all areas. The principle of equal pay for equal work became part of the Treaty of Rome in 1957.',
      extendedDescription: 'Equality in the EU goes beyond just legal provisions; it\'s a cultural and societal goal.While laws and regulations, like the principle of equal pay for equal work, ensure fairness in tangible terms, the EU\'s commitment to equality seeks to address deeper societal biases and structures. Whether it\'s gender equality, ensuring equal opportunities irrespective of racial or ethnic backgrounds, or advocating for the rights of the differently- abled, the EU\'s vision for equality is comprehensive. Through a mix of policies, advocacy, and grassroots initiatives, the EU strives for a society where every individual can realize their potential without facing discrimination.'
    },
    {
      title: 'Rule of law',
      shortDescription: 'The EU is based on the rule of law. Everything the EU does is founded on treaties, voluntarily and democratically agreed by its EU countries. Law and justice are upheld by an independent judiciary. The EU countries gave final jurisdiction to the European Court of Justice - its judgments have to be respected by all.',
      extendedDescription: 'The rule of law is fundamental to the very existence and functioning of the EU. It ensures that all actions, policies, and decisions taken within the Union are based on the law, rather than arbitrary decisions or whims. This principle guarantees fairness, predictability, and justice. The independent judiciary, with the European Court of Justice at its helm, ensures that laws are interpreted and applied uniformly across member states. By upholding the rule of law, the EU ensures that the rights of its citizens are protected and that there is a clear framework within which individuals, businesses, and governments can operate.',
      exploreUrl: '/present/article/rule-of-law'
    },
    {
      title: 'Human rights',
      shortDescription: 'Human rights are protected by the EU Charter of Fundamental Rights. These cover the right to be free from discrimination on the basis of sex, racial or ethnic origin, religion or belief, disability, age or sexual orientation, the right to the protection of your personal data, and the right to get access to justice.',
      extendedDescription: 'Human rights, as enshrined in the EU Charter of Fundamental Rights, provide a comprehensive framework that ensures the dignity, freedom, and well-being of every individual in the Union. These rights, which range from civil and political to social and economic, ensure that individuals can live without fear of persecution, have access to basic necessities, and can participate fully in the social, cultural, and economic life of the Union. The EU, through its institutions, policies, and legal frameworks, constantly works towards upholding and promoting these rights, both within its borders and globally.'
    }
  ];


  selectedTitle: string | null = null;
  selectedExtendedDescription: string | null = null;
  activeBox: number | null = null;

  constructor() { }

  ngOnInit(): void {
  }

  onBoxClick(index: number): void {
    if (this.activeBox === index) {
      this.activeBox = null;
      this.selectedExtendedDescription = null;
      this.selectedTitle = null;
    } else {
      this.activeBox = index;
      this.selectedExtendedDescription = this.values[index].extendedDescription;
      this.selectedTitle = this.values[index].title;
    }
  }
}
