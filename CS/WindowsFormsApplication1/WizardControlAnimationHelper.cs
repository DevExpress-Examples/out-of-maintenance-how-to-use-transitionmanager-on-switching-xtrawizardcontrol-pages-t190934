using DevExpress.Utils.Animation;
using DevExpress.XtraWizard;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1 {

    public enum TransitionType { PushTransition, ShapeTransition, FadeTransition, ClockTransition, DissolveTransition, SlideFadeTransition, CoverTransition, CombTransition }

    public class WizardControlAnimationHelper : Component {
        private Transition transition;
        private WizardControl _WizardControl;
        private TransitionManager _TransitionManager;
        private TransitionType _TransitionType;
        


        public WizardControlAnimationHelper() {
            transition = new Transition();
            transition.ShowWaitingIndicator = DevExpress.Utils.DefaultBoolean.False;
            TransitionType = WindowsFormsApplication1.TransitionType.PushTransition;
        }

        ~WizardControlAnimationHelper() {
            if (TransitionManager != null) {
                TransitionManager.Transitions.Remove(transition);
            }
        }

        public TransitionType TransitionType {
            get { return _TransitionType; }
            set {
                if (_TransitionType != value) {
                    _TransitionType = value;
                    if (!(this.DesignMode)) {
                        CustomizeTransitionType();
                    }
                }
            }
        }

        public WizardControl WizardControl {
            get {
                return _WizardControl;
            }
            set {
                if (_WizardControl != value) {
                    if (_WizardControl != null) {
                        _WizardControl.SelectedPageChanging -= WizardControl_SelectedPageChanging;
                        _WizardControl.SelectedPageChanged -= WizardControl_SelectedPageChanged;
                    }
                    _WizardControl = value;
                    if (!(this.DesignMode)) {
                        CustomizeWizardControl();
                    }
                }
            }
        }

        public TransitionManager TransitionManager {
            get { return _TransitionManager; }
            set {
                if (_TransitionManager != value) {
                    _TransitionManager = value;
                    if (!(this.DesignMode)) {
                        CustomizeTransitionManager();
                    }
                }
            }
        }

        private void CustomizeTransitionType() {
            switch (TransitionType) {
                case TransitionType.PushTransition:
                    PushTransition pt = new PushTransition();

                    transition.TransitionType = pt;
                    break;
                case TransitionType.ClockTransition:
                    transition.TransitionType = new ClockTransition();
                    break;
                case TransitionType.CombTransition:
                    transition.TransitionType = new CombTransition();
                    break;
                case TransitionType.CoverTransition:
                    transition.TransitionType = new CoverTransition();
                    break;
                case TransitionType.DissolveTransition:
                    transition.TransitionType = new DissolveTransition();
                    break;
                case TransitionType.FadeTransition:
                    transition.TransitionType = new FadeTransition();
                    break;
                case TransitionType.ShapeTransition:
                    transition.TransitionType = new ShapeTransition();
                    break;
                case TransitionType.SlideFadeTransition:
                    transition.TransitionType = new SlideFadeTransition();
                    break;
            }
        }

        private void CustomizeTransitionManager() {
            TransitionManager.Transitions.Add(transition);
            TransitionManager.CustomTransition += TransitionManager_CustomTransition;
        }

        void TransitionManager_CustomTransition(ITransition transition, CustomTransitionEventArgs e) {
            int dif = DevExpress.XtraWizard.WizardBaseConsts.CommandAreaHeight;
            e.Regions = new Rectangle[] { new Rectangle(WizardControl.Bounds.X, WizardControl.Bounds.Y, WizardControl.Bounds.Width, WizardControl.Bounds.Height - dif) };
        }

        private void CustomizeWizardControl() {
            WizardControl.AllowTransitionAnimation = false;
            transition.Control = WizardControl;
            WizardControl.SelectedPageChanging += WizardControl_SelectedPageChanging;
            WizardControl.SelectedPageChanged += WizardControl_SelectedPageChanged;
        }

        void WizardControl_SelectedPageChanged(object sender, WizardPageChangedEventArgs e) {
            if (TransitionManager != null) {
                TransitionManager.EndTransition();
            }
        }

        void WizardControl_SelectedPageChanging(object sender, WizardPageChangingEventArgs e) {
            if (TransitionManager != null) {
                TransitionManager.StartTransition(WizardControl);
            }
        }


    }
}
