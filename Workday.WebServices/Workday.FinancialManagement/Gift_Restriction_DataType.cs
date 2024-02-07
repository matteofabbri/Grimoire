using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Gift_Restriction_DataType : INotifyPropertyChanged
	{
		private Gift_PurposeObjectType primary_Purpose_ReferenceField;

		private Gift_PurposeObjectType[] gift_Purpose_ReferenceField;

		private Honorarium_TypeObjectType honorarium_Type_ReferenceField;

		private Release_LevelObjectType release_Level_ReferenceField;

		private bool matching_RequirementField;

		private bool matching_RequirementFieldSpecified;

		private bool allow_Underwater_SpendingField;

		private bool allow_Underwater_SpendingFieldSpecified;

		private bool yield_OnlyField;

		private bool yield_OnlyFieldSpecified;

		private string donor_Restriction_ExcerptField;

		private string restriction_DescriptionField;

		private string nature_of_RestrictionField;

		private Restricted_By_ValueObjectType restricted_By_Value_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Gift_PurposeObjectType Primary_Purpose_Reference
		{
			get
			{
				return this.primary_Purpose_ReferenceField;
			}
			set
			{
				this.primary_Purpose_ReferenceField = value;
				this.RaisePropertyChanged("Primary_Purpose_Reference");
			}
		}

		[XmlElement("Gift_Purpose_Reference", Order = 1)]
		public Gift_PurposeObjectType[] Gift_Purpose_Reference
		{
			get
			{
				return this.gift_Purpose_ReferenceField;
			}
			set
			{
				this.gift_Purpose_ReferenceField = value;
				this.RaisePropertyChanged("Gift_Purpose_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public Honorarium_TypeObjectType Honorarium_Type_Reference
		{
			get
			{
				return this.honorarium_Type_ReferenceField;
			}
			set
			{
				this.honorarium_Type_ReferenceField = value;
				this.RaisePropertyChanged("Honorarium_Type_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public Release_LevelObjectType Release_Level_Reference
		{
			get
			{
				return this.release_Level_ReferenceField;
			}
			set
			{
				this.release_Level_ReferenceField = value;
				this.RaisePropertyChanged("Release_Level_Reference");
			}
		}

		[XmlElement(Order = 4)]
		public bool Matching_Requirement
		{
			get
			{
				return this.matching_RequirementField;
			}
			set
			{
				this.matching_RequirementField = value;
				this.RaisePropertyChanged("Matching_Requirement");
			}
		}

		[XmlIgnore]
		public bool Matching_RequirementSpecified
		{
			get
			{
				return this.matching_RequirementFieldSpecified;
			}
			set
			{
				this.matching_RequirementFieldSpecified = value;
				this.RaisePropertyChanged("Matching_RequirementSpecified");
			}
		}

		[XmlElement(Order = 5)]
		public bool Allow_Underwater_Spending
		{
			get
			{
				return this.allow_Underwater_SpendingField;
			}
			set
			{
				this.allow_Underwater_SpendingField = value;
				this.RaisePropertyChanged("Allow_Underwater_Spending");
			}
		}

		[XmlIgnore]
		public bool Allow_Underwater_SpendingSpecified
		{
			get
			{
				return this.allow_Underwater_SpendingFieldSpecified;
			}
			set
			{
				this.allow_Underwater_SpendingFieldSpecified = value;
				this.RaisePropertyChanged("Allow_Underwater_SpendingSpecified");
			}
		}

		[XmlElement(Order = 6)]
		public bool Yield_Only
		{
			get
			{
				return this.yield_OnlyField;
			}
			set
			{
				this.yield_OnlyField = value;
				this.RaisePropertyChanged("Yield_Only");
			}
		}

		[XmlIgnore]
		public bool Yield_OnlySpecified
		{
			get
			{
				return this.yield_OnlyFieldSpecified;
			}
			set
			{
				this.yield_OnlyFieldSpecified = value;
				this.RaisePropertyChanged("Yield_OnlySpecified");
			}
		}

		[XmlElement(Order = 7)]
		public string Donor_Restriction_Excerpt
		{
			get
			{
				return this.donor_Restriction_ExcerptField;
			}
			set
			{
				this.donor_Restriction_ExcerptField = value;
				this.RaisePropertyChanged("Donor_Restriction_Excerpt");
			}
		}

		[XmlElement(Order = 8)]
		public string Restriction_Description
		{
			get
			{
				return this.restriction_DescriptionField;
			}
			set
			{
				this.restriction_DescriptionField = value;
				this.RaisePropertyChanged("Restriction_Description");
			}
		}

		[XmlElement(Order = 9)]
		public string Nature_of_Restriction
		{
			get
			{
				return this.nature_of_RestrictionField;
			}
			set
			{
				this.nature_of_RestrictionField = value;
				this.RaisePropertyChanged("Nature_of_Restriction");
			}
		}

		[XmlElement(Order = 10)]
		public Restricted_By_ValueObjectType Restricted_By_Value_Reference
		{
			get
			{
				return this.restricted_By_Value_ReferenceField;
			}
			set
			{
				this.restricted_By_Value_ReferenceField = value;
				this.RaisePropertyChanged("Restricted_By_Value_Reference");
			}
		}

		protected void RaisePropertyChanged(string propertyName)
		{
			PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if (propertyChanged != null)
			{
				propertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
