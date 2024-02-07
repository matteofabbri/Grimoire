using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Talent
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Assess_Potential_Event_DataType : INotifyPropertyChanged
	{
		private Talent_Matrix_Placement_Review_RatingObjectType talent_Matrix_Placement_ReferenceField;

		private PotentialObjectType potential_ReferenceField;

		private Review_RatingObjectType review_Rating_ReferenceField;

		private Achievable_LevelObjectType achievable_Level_ReferenceField;

		private RetentionObjectType retention_ReferenceField;

		private Loss_ImpactObjectType loss_Impact_ReferenceField;

		private string employee_Potential_Assessment_Field_1_ValueField;

		private string employee_Potential_Assessment_Field_2_ValueField;

		private Nomination_DataType[] nominations_DataField;

		private string notesField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Talent_Matrix_Placement_Review_RatingObjectType Talent_Matrix_Placement_Reference
		{
			get
			{
				return this.talent_Matrix_Placement_ReferenceField;
			}
			set
			{
				this.talent_Matrix_Placement_ReferenceField = value;
				this.RaisePropertyChanged("Talent_Matrix_Placement_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public PotentialObjectType Potential_Reference
		{
			get
			{
				return this.potential_ReferenceField;
			}
			set
			{
				this.potential_ReferenceField = value;
				this.RaisePropertyChanged("Potential_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public Review_RatingObjectType Review_Rating_Reference
		{
			get
			{
				return this.review_Rating_ReferenceField;
			}
			set
			{
				this.review_Rating_ReferenceField = value;
				this.RaisePropertyChanged("Review_Rating_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public Achievable_LevelObjectType Achievable_Level_Reference
		{
			get
			{
				return this.achievable_Level_ReferenceField;
			}
			set
			{
				this.achievable_Level_ReferenceField = value;
				this.RaisePropertyChanged("Achievable_Level_Reference");
			}
		}

		[XmlElement(Order = 4)]
		public RetentionObjectType Retention_Reference
		{
			get
			{
				return this.retention_ReferenceField;
			}
			set
			{
				this.retention_ReferenceField = value;
				this.RaisePropertyChanged("Retention_Reference");
			}
		}

		[XmlElement(Order = 5)]
		public Loss_ImpactObjectType Loss_Impact_Reference
		{
			get
			{
				return this.loss_Impact_ReferenceField;
			}
			set
			{
				this.loss_Impact_ReferenceField = value;
				this.RaisePropertyChanged("Loss_Impact_Reference");
			}
		}

		[XmlElement(Order = 6)]
		public string Employee_Potential_Assessment_Field_1_Value
		{
			get
			{
				return this.employee_Potential_Assessment_Field_1_ValueField;
			}
			set
			{
				this.employee_Potential_Assessment_Field_1_ValueField = value;
				this.RaisePropertyChanged("Employee_Potential_Assessment_Field_1_Value");
			}
		}

		[XmlElement(Order = 7)]
		public string Employee_Potential_Assessment_Field_2_Value
		{
			get
			{
				return this.employee_Potential_Assessment_Field_2_ValueField;
			}
			set
			{
				this.employee_Potential_Assessment_Field_2_ValueField = value;
				this.RaisePropertyChanged("Employee_Potential_Assessment_Field_2_Value");
			}
		}

		[XmlElement("Nominations_Data", Order = 8)]
		public Nomination_DataType[] Nominations_Data
		{
			get
			{
				return this.nominations_DataField;
			}
			set
			{
				this.nominations_DataField = value;
				this.RaisePropertyChanged("Nominations_Data");
			}
		}

		[XmlElement(Order = 9)]
		public string Notes
		{
			get
			{
				return this.notesField;
			}
			set
			{
				this.notesField = value;
				this.RaisePropertyChanged("Notes");
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
