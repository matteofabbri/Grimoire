using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Compensation
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Stock_Plan_DataType : INotifyPropertyChanged
	{
		private bool allow_Target_OverrideField;

		private bool allow_Target_OverrideFieldSpecified;

		private Compensation_MatrixObjectType compensation_Matrix_ReferenceField;

		private bool use_as_Reference_OnlyField;

		private bool use_as_Reference_OnlyFieldSpecified;

		private object itemField;

		private bool hide_TargetField;

		private bool hide_TargetFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public bool Allow_Target_Override
		{
			get
			{
				return this.allow_Target_OverrideField;
			}
			set
			{
				this.allow_Target_OverrideField = value;
				this.RaisePropertyChanged("Allow_Target_Override");
			}
		}

		[XmlIgnore]
		public bool Allow_Target_OverrideSpecified
		{
			get
			{
				return this.allow_Target_OverrideFieldSpecified;
			}
			set
			{
				this.allow_Target_OverrideFieldSpecified = value;
				this.RaisePropertyChanged("Allow_Target_OverrideSpecified");
			}
		}

		[XmlElement(Order = 1)]
		public Compensation_MatrixObjectType Compensation_Matrix_Reference
		{
			get
			{
				return this.compensation_Matrix_ReferenceField;
			}
			set
			{
				this.compensation_Matrix_ReferenceField = value;
				this.RaisePropertyChanged("Compensation_Matrix_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public bool Use_as_Reference_Only
		{
			get
			{
				return this.use_as_Reference_OnlyField;
			}
			set
			{
				this.use_as_Reference_OnlyField = value;
				this.RaisePropertyChanged("Use_as_Reference_Only");
			}
		}

		[XmlIgnore]
		public bool Use_as_Reference_OnlySpecified
		{
			get
			{
				return this.use_as_Reference_OnlyFieldSpecified;
			}
			set
			{
				this.use_as_Reference_OnlyFieldSpecified = value;
				this.RaisePropertyChanged("Use_as_Reference_OnlySpecified");
			}
		}

		[XmlElement("Stock_Plan_Amount_Data", typeof(Stock_Plan_Amount_DataType), Order = 3), XmlElement("Stock_Plan_Percent_Data", typeof(Stock_Plan_Percent_DataType), Order = 3), XmlElement("Stock_Plan_Unit_Data", typeof(Stock_Plan_Unit_DataType), Order = 3)]
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

		[XmlElement(Order = 4)]
		public bool Hide_Target
		{
			get
			{
				return this.hide_TargetField;
			}
			set
			{
				this.hide_TargetField = value;
				this.RaisePropertyChanged("Hide_Target");
			}
		}

		[XmlIgnore]
		public bool Hide_TargetSpecified
		{
			get
			{
				return this.hide_TargetFieldSpecified;
			}
			set
			{
				this.hide_TargetFieldSpecified = value;
				this.RaisePropertyChanged("Hide_TargetSpecified");
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
