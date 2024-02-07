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
	public class Close_Mentorship_Reason_DataType : INotifyPropertyChanged
	{
		private string idField;

		private string close_Mentorship_Reason_NameField;

		private string close_Mentorship_Reason_DescriptionField;

		private bool inactiveField;

		private bool inactiveFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string ID
		{
			get
			{
				return this.idField;
			}
			set
			{
				this.idField = value;
				this.RaisePropertyChanged("ID");
			}
		}

		[XmlElement(Order = 1)]
		public string Close_Mentorship_Reason_Name
		{
			get
			{
				return this.close_Mentorship_Reason_NameField;
			}
			set
			{
				this.close_Mentorship_Reason_NameField = value;
				this.RaisePropertyChanged("Close_Mentorship_Reason_Name");
			}
		}

		[XmlElement(Order = 2)]
		public string Close_Mentorship_Reason_Description
		{
			get
			{
				return this.close_Mentorship_Reason_DescriptionField;
			}
			set
			{
				this.close_Mentorship_Reason_DescriptionField = value;
				this.RaisePropertyChanged("Close_Mentorship_Reason_Description");
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
