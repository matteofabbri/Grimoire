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
	public class Proficiency_Rating_Scale_DataType : INotifyPropertyChanged
	{
		private string proficiency_Rating_Scale_IDField;

		private string rating_Scale_NameField;

		private string descriptionField;

		private bool inactiveField;

		private bool inactiveFieldSpecified;

		private Proficiency_Rating_DataType[] proficiency_Rating_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Proficiency_Rating_Scale_ID
		{
			get
			{
				return this.proficiency_Rating_Scale_IDField;
			}
			set
			{
				this.proficiency_Rating_Scale_IDField = value;
				this.RaisePropertyChanged("Proficiency_Rating_Scale_ID");
			}
		}

		[XmlElement(Order = 1)]
		public string Rating_Scale_Name
		{
			get
			{
				return this.rating_Scale_NameField;
			}
			set
			{
				this.rating_Scale_NameField = value;
				this.RaisePropertyChanged("Rating_Scale_Name");
			}
		}

		[XmlElement(Order = 2)]
		public string Description
		{
			get
			{
				return this.descriptionField;
			}
			set
			{
				this.descriptionField = value;
				this.RaisePropertyChanged("Description");
			}
		}

		[XmlElement(Order = 3)]
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

		[XmlElement("Proficiency_Rating_Data", Order = 4)]
		public Proficiency_Rating_DataType[] Proficiency_Rating_Data
		{
			get
			{
				return this.proficiency_Rating_DataField;
			}
			set
			{
				this.proficiency_Rating_DataField = value;
				this.RaisePropertyChanged("Proficiency_Rating_Data");
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
