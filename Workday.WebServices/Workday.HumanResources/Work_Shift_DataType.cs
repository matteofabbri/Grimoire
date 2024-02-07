using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.HumanResources
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Work_Shift_DataType : INotifyPropertyChanged
	{
		private string work_Shift_IDField;

		private string work_Shift_NameField;

		private string work_Shift_DescriptionField;

		private Location_ContextObjectType location_ReferenceField;

		private bool inactiveField;

		private bool inactiveFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Work_Shift_ID
		{
			get
			{
				return this.work_Shift_IDField;
			}
			set
			{
				this.work_Shift_IDField = value;
				this.RaisePropertyChanged("Work_Shift_ID");
			}
		}

		[XmlElement(Order = 1)]
		public string Work_Shift_Name
		{
			get
			{
				return this.work_Shift_NameField;
			}
			set
			{
				this.work_Shift_NameField = value;
				this.RaisePropertyChanged("Work_Shift_Name");
			}
		}

		[XmlElement(Order = 2)]
		public string Work_Shift_Description
		{
			get
			{
				return this.work_Shift_DescriptionField;
			}
			set
			{
				this.work_Shift_DescriptionField = value;
				this.RaisePropertyChanged("Work_Shift_Description");
			}
		}

		[XmlElement(Order = 3)]
		public Location_ContextObjectType Location_Reference
		{
			get
			{
				return this.location_ReferenceField;
			}
			set
			{
				this.location_ReferenceField = value;
				this.RaisePropertyChanged("Location_Reference");
			}
		}

		[XmlElement(Order = 4)]
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
