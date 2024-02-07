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
	public class Competency_DataType : INotifyPropertyChanged
	{
		private string competency_IDField;

		private string competency_NameField;

		private string competency_DescriptionField;

		private Competency_CategoryObjectType[] competency_Category_ReferenceField;

		private Competency_Rating_Behavior_DataType[] proficiency_Rating_Behavior_DataField;

		private bool inactiveField;

		private bool inactiveFieldSpecified;

		private DateTime effective_DateField;

		private bool effective_DateFieldSpecified;

		private Proficiency_Rating_ScaleObjectType proficiency_Rating_Scale_ReferenceField;

		private bool behaviors_Apply_to_All_LevelsField;

		private bool behaviors_Apply_to_All_LevelsFieldSpecified;

		private bool used_For_Talent_MatrixField;

		private bool used_For_Talent_MatrixFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Competency_ID
		{
			get
			{
				return this.competency_IDField;
			}
			set
			{
				this.competency_IDField = value;
				this.RaisePropertyChanged("Competency_ID");
			}
		}

		[XmlElement(Order = 1)]
		public string Competency_Name
		{
			get
			{
				return this.competency_NameField;
			}
			set
			{
				this.competency_NameField = value;
				this.RaisePropertyChanged("Competency_Name");
			}
		}

		[XmlElement(Order = 2)]
		public string Competency_Description
		{
			get
			{
				return this.competency_DescriptionField;
			}
			set
			{
				this.competency_DescriptionField = value;
				this.RaisePropertyChanged("Competency_Description");
			}
		}

		[XmlElement("Competency_Category_Reference", Order = 3)]
		public Competency_CategoryObjectType[] Competency_Category_Reference
		{
			get
			{
				return this.competency_Category_ReferenceField;
			}
			set
			{
				this.competency_Category_ReferenceField = value;
				this.RaisePropertyChanged("Competency_Category_Reference");
			}
		}

		[XmlElement("Proficiency_Rating_Behavior_Data", Order = 4)]
		public Competency_Rating_Behavior_DataType[] Proficiency_Rating_Behavior_Data
		{
			get
			{
				return this.proficiency_Rating_Behavior_DataField;
			}
			set
			{
				this.proficiency_Rating_Behavior_DataField = value;
				this.RaisePropertyChanged("Proficiency_Rating_Behavior_Data");
			}
		}

		[XmlElement(Order = 5)]
		public bool Inactive
		{
			get
			{
				return this.inactiveField;
			}
			set
			{
				this.inactiveField = value;
				this.RaisePropertyChanged("Inactive");
			}
		}

		[XmlIgnore]
		public bool InactiveSpecified
		{
			get
			{
				return this.inactiveFieldSpecified;
			}
			set
			{
				this.inactiveFieldSpecified = value;
				this.RaisePropertyChanged("InactiveSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 6)]
		public DateTime Effective_Date
		{
			get
			{
				return this.effective_DateField;
			}
			set
			{
				this.effective_DateField = value;
				this.RaisePropertyChanged("Effective_Date");
			}
		}

		[XmlIgnore]
		public bool Effective_DateSpecified
		{
			get
			{
				return this.effective_DateFieldSpecified;
			}
			set
			{
				this.effective_DateFieldSpecified = value;
				this.RaisePropertyChanged("Effective_DateSpecified");
			}
		}

		[XmlElement(Order = 7)]
		public Proficiency_Rating_ScaleObjectType Proficiency_Rating_Scale_Reference
		{
			get
			{
				return this.proficiency_Rating_Scale_ReferenceField;
			}
			set
			{
				this.proficiency_Rating_Scale_ReferenceField = value;
				this.RaisePropertyChanged("Proficiency_Rating_Scale_Reference");
			}
		}

		[XmlElement(Order = 8)]
		public bool Behaviors_Apply_to_All_Levels
		{
			get
			{
				return this.behaviors_Apply_to_All_LevelsField;
			}
			set
			{
				this.behaviors_Apply_to_All_LevelsField = value;
				this.RaisePropertyChanged("Behaviors_Apply_to_All_Levels");
			}
		}

		[XmlIgnore]
		public bool Behaviors_Apply_to_All_LevelsSpecified
		{
			get
			{
				return this.behaviors_Apply_to_All_LevelsFieldSpecified;
			}
			set
			{
				this.behaviors_Apply_to_All_LevelsFieldSpecified = value;
				this.RaisePropertyChanged("Behaviors_Apply_to_All_LevelsSpecified");
			}
		}

		[XmlElement(Order = 9)]
		public bool Used_For_Talent_Matrix
		{
			get
			{
				return this.used_For_Talent_MatrixField;
			}
			set
			{
				this.used_For_Talent_MatrixField = value;
				this.RaisePropertyChanged("Used_For_Talent_Matrix");
			}
		}

		[XmlIgnore]
		public bool Used_For_Talent_MatrixSpecified
		{
			get
			{
				return this.used_For_Talent_MatrixFieldSpecified;
			}
			set
			{
				this.used_For_Talent_MatrixFieldSpecified = value;
				this.RaisePropertyChanged("Used_For_Talent_MatrixSpecified");
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
