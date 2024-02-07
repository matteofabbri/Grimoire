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
	public class Position_Restrictions_Custom_Object_DataType : INotifyPropertyChanged
	{
		private DateTime effective_DateField;

		private bool effective_DateFieldSpecified;

		private Position_RestrictionsObjectType position_Restrictions_ReferenceField;

		private Effective_Dated_Web_Service_Additional_DataType[] business_Object_Additional_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(DataType = "date", Order = 0)]
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

		[XmlElement(Order = 1)]
		public Position_RestrictionsObjectType Position_Restrictions_Reference
		{
			get
			{
				return this.position_Restrictions_ReferenceField;
			}
			set
			{
				this.position_Restrictions_ReferenceField = value;
				this.RaisePropertyChanged("Position_Restrictions_Reference");
			}
		}

		[XmlElement("Business_Object_Additional_Data", Order = 2)]
		public Effective_Dated_Web_Service_Additional_DataType[] Business_Object_Additional_Data
		{
			get
			{
				return this.business_Object_Additional_DataField;
			}
			set
			{
				this.business_Object_Additional_DataField = value;
				this.RaisePropertyChanged("Business_Object_Additional_Data");
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
