using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Staffing
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Competency_Achievement_Data__v10_Type : INotifyPropertyChanged
	{
		private Unique_IdentifierObjectType competency_Level_Behavior_ReferenceField;

		private string competency_Level_Behavior_DescriptorField;

		private string assessment_CommentField;

		private DateTime assessed_OnField;

		private bool assessed_OnFieldSpecified;

		private RoleObjectType assessed_By_Person_ReferenceField;

		private string assessed_By_Worker_DescriptorField;

		private CompetencyObjectType competency_ReferenceField;

		private string competency_DescriptorField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Unique_IdentifierObjectType Competency_Level_Behavior_Reference
		{
			get
			{
				return this.competency_Level_Behavior_ReferenceField;
			}
			set
			{
				this.competency_Level_Behavior_ReferenceField = value;
				this.RaisePropertyChanged("Competency_Level_Behavior_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public string Competency_Level_Behavior_Descriptor
		{
			get
			{
				return this.competency_Level_Behavior_DescriptorField;
			}
			set
			{
				this.competency_Level_Behavior_DescriptorField = value;
				this.RaisePropertyChanged("Competency_Level_Behavior_Descriptor");
			}
		}

		[XmlElement(Order = 2)]
		public string Assessment_Comment
		{
			get
			{
				return this.assessment_CommentField;
			}
			set
			{
				this.assessment_CommentField = value;
				this.RaisePropertyChanged("Assessment_Comment");
			}
		}

		[XmlElement(DataType = "date", Order = 3)]
		public DateTime Assessed_On
		{
			get
			{
				return this.assessed_OnField;
			}
			set
			{
				this.assessed_OnField = value;
				this.RaisePropertyChanged("Assessed_On");
			}
		}

		[XmlIgnore]
		public bool Assessed_OnSpecified
		{
			get
			{
				return this.assessed_OnFieldSpecified;
			}
			set
			{
				this.assessed_OnFieldSpecified = value;
				this.RaisePropertyChanged("Assessed_OnSpecified");
			}
		}

		[XmlElement(Order = 4)]
		public RoleObjectType Assessed_By_Person_Reference
		{
			get
			{
				return this.assessed_By_Person_ReferenceField;
			}
			set
			{
				this.assessed_By_Person_ReferenceField = value;
				this.RaisePropertyChanged("Assessed_By_Person_Reference");
			}
		}

		[XmlElement(Order = 5)]
		public string Assessed_By_Worker_Descriptor
		{
			get
			{
				return this.assessed_By_Worker_DescriptorField;
			}
			set
			{
				this.assessed_By_Worker_DescriptorField = value;
				this.RaisePropertyChanged("Assessed_By_Worker_Descriptor");
			}
		}

		[XmlElement(Order = 6)]
		public CompetencyObjectType Competency_Reference
		{
			get
			{
				return this.competency_ReferenceField;
			}
			set
			{
				this.competency_ReferenceField = value;
				this.RaisePropertyChanged("Competency_Reference");
			}
		}

		[XmlElement(Order = 7)]
		public string Competency_Descriptor
		{
			get
			{
				return this.competency_DescriptorField;
			}
			set
			{
				this.competency_DescriptorField = value;
				this.RaisePropertyChanged("Competency_Descriptor");
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
