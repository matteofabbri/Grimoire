using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Opportunity_Response_GroupType : INotifyPropertyChanged
	{
		private bool include_ReferenceField;

		private bool include_ReferenceFieldSpecified;

		private bool include_Opportunity_Cost_DataField;

		private bool include_Opportunity_Cost_DataFieldSpecified;

		private bool include_Opportunity_DataField;

		private bool include_Opportunity_DataFieldSpecified;

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
		public bool Include_Opportunity_Cost_Data
		{
			get
			{
				return this.include_Opportunity_Cost_DataField;
			}
			set
			{
				this.include_Opportunity_Cost_DataField = value;
				this.RaisePropertyChanged("Include_Opportunity_Cost_Data");
			}
		}

		[XmlIgnore]
		public bool Include_Opportunity_Cost_DataSpecified
		{
			get
			{
				return this.include_Opportunity_Cost_DataFieldSpecified;
			}
			set
			{
				this.include_Opportunity_Cost_DataFieldSpecified = value;
				this.RaisePropertyChanged("Include_Opportunity_Cost_DataSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public bool Include_Opportunity_Data
		{
			get
			{
				return this.include_Opportunity_DataField;
			}
			set
			{
				this.include_Opportunity_DataField = value;
				this.RaisePropertyChanged("Include_Opportunity_Data");
			}
		}

		[XmlIgnore]
		public bool Include_Opportunity_DataSpecified
		{
			get
			{
				return this.include_Opportunity_DataFieldSpecified;
			}
			set
			{
				this.include_Opportunity_DataFieldSpecified = value;
				this.RaisePropertyChanged("Include_Opportunity_DataSpecified");
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
