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
	public class Performance_Matrix_DataType : INotifyPropertyChanged
	{
		private Compensation_MatrixObjectType compensation_Matrix_ReferenceField;

		private bool use_Matrix_as_Reference_OnlyField;

		private bool use_Matrix_as_Reference_OnlyFieldSpecified;

		private Default_ScorecardObjectType bonus_Modifier_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
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

		[XmlElement(Order = 1)]
		public bool Use_Matrix_as_Reference_Only
		{
			get
			{
				return this.use_Matrix_as_Reference_OnlyField;
			}
			set
			{
				this.use_Matrix_as_Reference_OnlyField = value;
				this.RaisePropertyChanged("Use_Matrix_as_Reference_Only");
			}
		}

		[XmlIgnore]
		public bool Use_Matrix_as_Reference_OnlySpecified
		{
			get
			{
				return this.use_Matrix_as_Reference_OnlyFieldSpecified;
			}
			set
			{
				this.use_Matrix_as_Reference_OnlyFieldSpecified = value;
				this.RaisePropertyChanged("Use_Matrix_as_Reference_OnlySpecified");
			}
		}

		[XmlElement(Order = 2)]
		public Default_ScorecardObjectType Bonus_Modifier_Reference
		{
			get
			{
				return this.bonus_Modifier_ReferenceField;
			}
			set
			{
				this.bonus_Modifier_ReferenceField = value;
				this.RaisePropertyChanged("Bonus_Modifier_Reference");
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
