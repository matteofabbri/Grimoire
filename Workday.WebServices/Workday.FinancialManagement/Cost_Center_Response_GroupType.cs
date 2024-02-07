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
	public class Cost_Center_Response_GroupType : INotifyPropertyChanged
	{
		private bool include_ReferenceField;

		private bool include_ReferenceFieldSpecified;

		private bool include_Cost_Center_DataField;

		private bool include_Cost_Center_DataFieldSpecified;

		private bool include_Simple_Cost_Center_DataField;

		private bool include_Simple_Cost_Center_DataFieldSpecified;

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
		public bool Include_Cost_Center_Data
		{
			get
			{
				return this.include_Cost_Center_DataField;
			}
			set
			{
				this.include_Cost_Center_DataField = value;
				this.RaisePropertyChanged("Include_Cost_Center_Data");
			}
		}

		[XmlIgnore]
		public bool Include_Cost_Center_DataSpecified
		{
			get
			{
				return this.include_Cost_Center_DataFieldSpecified;
			}
			set
			{
				this.include_Cost_Center_DataFieldSpecified = value;
				this.RaisePropertyChanged("Include_Cost_Center_DataSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public bool Include_Simple_Cost_Center_Data
		{
			get
			{
				return this.include_Simple_Cost_Center_DataField;
			}
			set
			{
				this.include_Simple_Cost_Center_DataField = value;
				this.RaisePropertyChanged("Include_Simple_Cost_Center_Data");
			}
		}

		[XmlIgnore]
		public bool Include_Simple_Cost_Center_DataSpecified
		{
			get
			{
				return this.include_Simple_Cost_Center_DataFieldSpecified;
			}
			set
			{
				this.include_Simple_Cost_Center_DataFieldSpecified = value;
				this.RaisePropertyChanged("Include_Simple_Cost_Center_DataSpecified");
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
