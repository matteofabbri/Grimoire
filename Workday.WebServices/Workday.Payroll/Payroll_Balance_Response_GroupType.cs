using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Payroll
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Payroll_Balance_Response_GroupType : INotifyPropertyChanged
	{
		private bool include_Name_DataField;

		private bool include_Name_DataFieldSpecified;

		private bool include_National_ID_DataField;

		private bool include_National_ID_DataFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public bool Include_Name_Data
		{
			get
			{
				return this.include_Name_DataField;
			}
			set
			{
				this.include_Name_DataField = value;
				this.RaisePropertyChanged("Include_Name_Data");
			}
		}

		[XmlIgnore]
		public bool Include_Name_DataSpecified
		{
			get
			{
				return this.include_Name_DataFieldSpecified;
			}
			set
			{
				this.include_Name_DataFieldSpecified = value;
				this.RaisePropertyChanged("Include_Name_DataSpecified");
			}
		}

		[XmlElement(Order = 1)]
		public bool Include_National_ID_Data
		{
			get
			{
				return this.include_National_ID_DataField;
			}
			set
			{
				this.include_National_ID_DataField = value;
				this.RaisePropertyChanged("Include_National_ID_Data");
			}
		}

		[XmlIgnore]
		public bool Include_National_ID_DataSpecified
		{
			get
			{
				return this.include_National_ID_DataFieldSpecified;
			}
			set
			{
				this.include_National_ID_DataFieldSpecified = value;
				this.RaisePropertyChanged("Include_National_ID_DataSpecified");
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
