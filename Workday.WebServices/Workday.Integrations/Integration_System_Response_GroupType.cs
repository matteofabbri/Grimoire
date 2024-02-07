using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Integrations
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Integration_System_Response_GroupType : INotifyPropertyChanged
	{
		private bool include_ReferenceField;

		private bool include_ReferenceFieldSpecified;

		private bool show_Values_For_All_EnvironmentsField;

		private bool show_Values_For_All_EnvironmentsFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public bool Include_Reference
		{
			get
			{
				return this.include_ReferenceField;
			}
			set
			{
				this.include_ReferenceField = value;
				this.RaisePropertyChanged("Include_Reference");
			}
		}

		[XmlIgnore]
		public bool Include_ReferenceSpecified
		{
			get
			{
				return this.include_ReferenceFieldSpecified;
			}
			set
			{
				this.include_ReferenceFieldSpecified = value;
				this.RaisePropertyChanged("Include_ReferenceSpecified");
			}
		}

		[XmlElement(Order = 1)]
		public bool Show_Values_For_All_Environments
		{
			get
			{
				return this.show_Values_For_All_EnvironmentsField;
			}
			set
			{
				this.show_Values_For_All_EnvironmentsField = value;
				this.RaisePropertyChanged("Show_Values_For_All_Environments");
			}
		}

		[XmlIgnore]
		public bool Show_Values_For_All_EnvironmentsSpecified
		{
			get
			{
				return this.show_Values_For_All_EnvironmentsFieldSpecified;
			}
			set
			{
				this.show_Values_For_All_EnvironmentsFieldSpecified = value;
				this.RaisePropertyChanged("Show_Values_For_All_EnvironmentsSpecified");
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
