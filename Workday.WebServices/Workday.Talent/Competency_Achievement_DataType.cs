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
	public class Competency_Achievement_DataType : INotifyPropertyChanged
	{
		private CompetencyObjectType competency_ReferenceField;

		private object itemField;

		private string noteField;

		private DateTime assessed_OnField;

		private bool assessed_OnFieldSpecified;

		private RoleObjectType assessed_By_Role_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
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

		[XmlElement("Competency_Level_Behavior_Reference", typeof(Unique_IdentifierObjectType), Order = 1), XmlElement("Competency_Level_Reference", typeof(Proficiency_RatingObjectType), Order = 1)]
		public object Item
		{
			get
			{
				return this.itemField;
			}
			set
			{
				this.itemField = value;
				this.RaisePropertyChanged("Item");
			}
		}

		[XmlElement(Order = 2)]
		public string Note
		{
			get
			{
				return this.noteField;
			}
			set
			{
				this.noteField = value;
				this.RaisePropertyChanged("Note");
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
		public RoleObjectType Assessed_By_Role_Reference
		{
			get
			{
				return this.assessed_By_Role_ReferenceField;
			}
			set
			{
				this.assessed_By_Role_ReferenceField = value;
				this.RaisePropertyChanged("Assessed_By_Role_Reference");
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
